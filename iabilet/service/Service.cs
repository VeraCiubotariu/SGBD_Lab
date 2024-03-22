using System.Collections.Generic;
using iabilet.domain;
using iabilet.repository;

namespace iabilet.service
{
    public class Service: IObservable
    {
        private DBRepository _repo;
        private List<IObserver> _observers = new List<IObserver>();

        public Service(DBRepository repo)
        {
            this._repo = repo;
        }

        public List<Genre> GetAllGenres()
        {
            return _repo.GetAllGenres();
        }

        public List<Artist> GetAllArtistsByGenre(int genreId)
        {
            return _repo.GetAllArtistsByGenre(genreId);
        }

        public Artist DeleteArtist(Artist artist)
        {
            Artist returnValue = _repo.DeleteArtist(artist);
            if (returnValue != null)
            {
                Notify();
            }

            return returnValue;
        }

        public Artist AddArtist(Artist artist)
        {
            Artist returnValue = _repo.AddArtist(artist);
            if (returnValue == null)
            {
                Notify();
            }

            return returnValue;
        }

        public Artist UpdateArtist(Artist artist)
        {
            Artist returnValue = _repo.UpdateArtist(artist);
            if (returnValue == null)
            {
                Notify();
            }

            return returnValue;
        }

        public void AddObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void DeleteObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}