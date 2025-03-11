using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;

public class BasicInteractor : XRBaseControllerInteractor
{
    public override void GetActivateTargets(List<IXRActivateInteractable>
       validTargets)
    { }

    protected virtual List<XRBaseInteractable> ValidTargets { get; }
}