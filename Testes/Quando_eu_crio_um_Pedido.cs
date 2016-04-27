using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using Domain.Mobile.Interface;
using Domain.Mobile.Entities;
using Testes.UnitOfWork;
using Moq;
using System.Collections.Generic;
using Testes.Repositories;

namespace Testes
{
    [TestClass]
    public class Quando_eu_crio_um_Pedido
    {

        /*IKernel kernel = new StandardKernel(new AppModule());
        private Mock<IUnitOfWork> mockUnitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            var mockUnitOfWork = new Mock<IUnitOfWork>();
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void deve_retornar_uma_excecao_pois_nao_existe_lotes()
        {
            
            var mockServicoRegistroPedido = new Mock<ServicoRegistroLote>(mockUnitOfWork.Object);

            mockUnitOfWork.Setup(x => x.Lotes)
                .Returns(() => null);

            mockUnitOfWork.Setup(x => x.PontosDeVenda.GetSingle(1)).Returns(
                new PontoDeVenda(
                    new Endereco("Rua 1", 12, "", "608425"),
                    "Gaucho",
                    "(85) 985485585",
                    "Sr. Gaucho"
                    )
                );
             mockUnitOfWork.Setup(x => x.Produtos.GetSingle(1)).Returns(
                new Produto("Tradicional", 10, 2m)
                );

            var ponto = mockUnitOfWork.Object.PontosDeVenda.GetSingle(1);
            var produto = mockUnitOfWork.Object.Produtos.GetSingle(1);

            
            var quantidade = 10;
            var dataPedido = DateTime.Now;
            var prazoValidadeParaVenda = 5;

            var pedido = new PedidoModel(ponto, produto, dataPedido, quantidade, prazoValidadeParaVenda);

            mockServicoRegistroPedido.Object.RegistrarPedido(pedido);

            mockServicoRegistroPedido.Setup(x => x.RegistrarPedido(pedido))
                .Throws<Exception>();
        }

        [TestMethod]
        public void deve_entrar_no_metodo_salvar_uma_vez()
        {
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            var mockServicoRegistroPedido = new Mock<ServicoRegistroLote>(mockUnitOfWork.Object);
            

            mockUnitOfWork.Setup(x => x.Pedidos).Returns(It.IsAny<IRepository<Pedido>>());

            mockUnitOfWork.Setup(x => x.PontosDeVenda.GetSingle(1)).Returns(
                new PontoDeVenda(
                    new Endereco("Rua 1", 12, "", "608425"),
                    "Gaucho",
                    "(85) 985485585",
                    "Sr. Gaucho"
                    )
                );
            mockUnitOfWork.Setup(x => x.Produtos.GetSingle(1)).Returns(
               new Produto("Tradicional", 10, 2m)
               );

            var ponto = mockUnitOfWork.Object.PontosDeVenda.GetSingle(1);
            var produto = mockUnitOfWork.Object.Produtos.GetSingle(1);

            
            var quantidade = 8;
            var dataPedido = DateTime.Now;
            var prazoValidadeParaVenda = 5;

            var pedido = new PedidoModel(ponto, produto, dataPedido, quantidade, prazoValidadeParaVenda);

            mockUnitOfWork.Setup(x => x.Lotes.GetLotesValidos(produto.Id, pedido.DataPedido, prazoValidadeParaVenda)).Returns(new List<Lote>()
            {
                new Lote( new Produto("Tradicional", 10, 2m), DateTime.Now, 50 ),
                new Lote( new Produto("Tradicional", 10, 2m), DateTime.Now.AddDays(-1), 25)
            });

            mockUnitOfWork.Setup(x => x.Pedidos.GetAll()).Returns(new List<Pedido>());
            mockServicoRegistroPedido.Object.RegistrarPedido(pedido);


            mockServicoRegistroPedido.Verify(x => x.ConcluirPedido(), Times.AtLeastOnce);
        }*/
    }
}
