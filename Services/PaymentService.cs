using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandT.Models;
using TheRuhuahs_TandT.Models.ViewModel;
using TheRuhuahs_TandT.Repositories;

namespace TheRuhuahs_TandT.Services
{
    public class PaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public Payment AddPayment(CreatePaymentViewModel model)
        {
            var payment = new Payment
            {
                UserId = model.UserId,
                Amount = model.Amount,
                CreatedAt = model.CreatedAt,
                BookingId = model.BookingId

            };
            if(model.UserId == payment.UserId)
            {
               
            }
            return _paymentRepository.AddPayment(payment);
        }
        public Payment UpdatePayment(Payment payment)
        {
            return _paymentRepository.UpdatePayment(payment);
        }

        public Payment FindByPaymentId(int id)
        {
            return _paymentRepository.FindByPaymentId(id);
        }

        public void DeletePayment(int id)
        {
            _paymentRepository.DeletePayment(id);
        }
        public List<PaymentViewModel> GetPayment()
        {
            var payment = _paymentRepository.GetPayment().Select(c => new PaymentViewModel
            {
                UserId = c.UserId,
                Amount = c.Amount,
                CreatedAt = c.CreatedAt,
                BookingId = c.BookingId
               
            }).ToList();

            return payment;
        }
    }
}