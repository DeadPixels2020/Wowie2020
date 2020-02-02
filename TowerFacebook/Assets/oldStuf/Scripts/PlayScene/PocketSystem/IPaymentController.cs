public interface IPaymentController{

    void Pay(Costs costs);

    bool TryToPay(Costs costs);

    bool AbleToPay(Costs costs);

}