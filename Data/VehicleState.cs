using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerSamples.Data
{
    public class VehicleState
    {
        public event Action OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();

        public string SelectedVehicle { get; set; }

        public void SetVehicle (string vehicle)
        {
            SelectedVehicle = vehicle;
            NotifyStateChanged();
        }
    }
}
