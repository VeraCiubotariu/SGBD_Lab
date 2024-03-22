using System;

namespace iabilet.domain.validators
{
    public class ArtistValidator: IValidator<Artist>
    {
        public void Validate(Artist artist)
        {
            if (String.IsNullOrEmpty(artist.Name))
            {
                throw new ValidationException("Invalid name");
            }
        }
    }
}