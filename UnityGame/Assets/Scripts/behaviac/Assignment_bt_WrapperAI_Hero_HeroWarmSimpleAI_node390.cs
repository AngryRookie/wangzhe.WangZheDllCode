using System;
using UnityEngine;

namespace behaviac
{
	internal class Assignment_bt_WrapperAI_Hero_HeroWarmSimpleAI_node390 : Assignment
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			EBTStatus result = EBTStatus.BT_SUCCESS;
			Vector3 value = (Vector3)pAgent.GetVariable(2613103010u);
			pAgent.SetVariable<Vector3>("p_attackPathCurTargetPos", value, 312907864u);
			return result;
		}
	}
}
