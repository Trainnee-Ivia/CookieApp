using Domain.Mobile.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using RestSharp;
using Newtonsoft.Json;

namespace Infraestrutura.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private RestClient client;
        private string RestRequest;

        public Repository(string restRequest)
        {
            client = new RestClient("http://apicookie.azurewebsites.net");
            this.RestRequest = restRequest;
        }

        public void Add(T entity)
        {
            var request = new RestRequest(RestRequest, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(entity);
            //client.Execute(request);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            var request = new RestRequest(RestRequest, Method.POST);
            request.RequestFormat = DataFormat.Json;
            foreach (var item in entities)
            {
                request.AddBody(item);
            }
            //client.Execute(request);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            var request = new RestRequest(RestRequest, Method.GET);
            string Json = client.Execute(request).Content;

            return JsonConvert.DeserializeObject<IEnumerable<T>>(Json);
        }

        public T GetSingle(int id)
        {
            var request = new RestRequest(RestRequest + "/{id}", Method.GET );
            //request.AddHeader("Authorization", "Bearer ")
            request.AddParameter("id", id);
            string Json = client.Execute(request).Content;

            return JsonConvert.DeserializeObject<T>(Json);
        }

        public void Remove(T entity)
        {
            /*var request = new RestRequest(RestRequest + "/{id}", Method.GET);
            request.AddParameter("id", entity.Id);

            client.Execute(request);*/
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
