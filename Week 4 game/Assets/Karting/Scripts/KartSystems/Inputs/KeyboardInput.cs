using UnityEngine;

namespace KartGame.KartSystems {

    public class KeyboardInput : BaseInput
    {
        public string TurnInputName;
        public string AccelerateButtonName;
        public string BrakeButtonName;

        public override InputData GenerateInput() {
            //print(gameObject.name + "; " + TurnInputName + ": " + Input.GetAxis(TurnInputName) + ". " + AccelerateButtonName + ": " + Input.GetAxis(AccelerateButtonName) + ". " + BrakeButtonName + ": " + Input.GetAxis(BrakeButtonName));
            return new InputData
            {
                Accelerate = Input.GetButton(AccelerateButtonName),
                Brake = Input.GetButton(BrakeButtonName),
                TurnInput = Input.GetAxis(TurnInputName)
            };
        }
    }
}
