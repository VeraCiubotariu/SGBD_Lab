namespace iabilet.domain.validators
{
    public interface IValidator<TE>
    {
        void Validate(TE entity);
    }
}