namespace BlazorDispositivo.Services
{
    using BlazorDispositivo.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class DeviceService
    {
        private readonly DeviceContext _context;

        public DeviceService(DeviceContext context)
        {
            _context = context;
        }

        public List<Dispositivo> GetDispositivos()
        {
            return _context.Dispositivos.ToList();
        }

        public void AddDispositivo(Dispositivo dispositivo)
        {
            _context.Dispositivos.Add(dispositivo);
            _context.SaveChanges();
        }

        public void UpdateDispositivo(Dispositivo dispositivo)
        {
            _context.Dispositivos.Update(dispositivo);
            _context.SaveChanges();
        }

        public void DeleteDispositivo(int id)
        {
            var dispositivo = _context.Dispositivos.Find(id);
            if (dispositivo != null)
            {
                _context.Dispositivos.Remove(dispositivo);
                _context.SaveChanges();
            }
        }
    }
}
