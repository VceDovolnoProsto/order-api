using FluentValidation;
using order_api.application.Common.Exceptions;
using order_api.application.Common.Interfaces;

namespace order_api.application.Orders.Commands.Update
{
    public class UpdateOrderValidator : AbstractValidator<UpdateOrder>
    {
        private readonly IOrdersRepository _ordersRepository;

        public UpdateOrderValidator(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;

            RuleFor(x => x.Id)
                .GreaterThan(0);

            RuleFor(x => x.Id)
                .CustomAsync(ValidateEntityExists);
        }

        private async Task ValidateEntityExists(
            long id,
            ValidationContext<UpdateOrder> context,
            CancellationToken cancellationToken)
        {
            var res = await _ordersRepository.GetById(id);

            if (res == null)
            {
                throw new EntityNotFoundException();
            }
        }
    }
}