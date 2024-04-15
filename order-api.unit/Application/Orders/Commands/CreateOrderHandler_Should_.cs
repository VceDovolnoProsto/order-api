using Moq;
using order_api.application.Common.Interfaces;
using order_api.application.Orders.Commands.Create;
using order_api.application.Orders.Models;
using order_api.domain.Entities;
using Xunit;

namespace order_api.unit.Application.Orders.Commands
{
    public class CreateOrderHandler_Should_
    {
        private readonly Mock<IOrdersRepository> _ordersRepository;
        private readonly CreateOrderHandler _handler;

        public CreateOrderHandler_Should_()
        {
            _ordersRepository = new Mock<IOrdersRepository>();
            _ordersRepository.Setup(m => m.CreateOrder(It.IsAny<Order>()));
            _handler = new CreateOrderHandler(_ordersRepository.Object);
        }

        [Fact]
        public async Task Successfully_Create_Order()
        {
            // Arrange
            var createOrderDto = new CreateOrderDto
            {
                SourceNote = "Test",
                Name = "Test"
            };

            // Act
            await _handler.Handle(new CreateOrder(createOrderDto), CancellationToken.None);

            // Assert
            _ordersRepository.Verify(x => 
                    x.CreateOrder(It.Is<Order>(x => 
                        x.SourceNote == createOrderDto.SourceNote 
                        && x.Name == createOrderDto.Name)), 
                Times.Once);
        }
    }
}