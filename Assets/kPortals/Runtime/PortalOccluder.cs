﻿using UnityEngine;

namespace kTools.Portals
{
	[ExecuteInEditMode]
    [AddComponentMenu("kTools/Portals/Portal Occluder")]
	public sealed class PortalOccluder : MonoBehaviour 
	{
		// -------------------------------------------------- //
        //                   PUBLIC METHODS                   //
        // -------------------------------------------------- //

		/// <summary>
        /// Converts this Monobehaviour to a SerializableOccluder struct for storage.
        /// </summary>
		public SerializableOccluder Serialize()
		{
			return new SerializableOccluder()
			{
				positionWS = transform.position,
				rotationWS = transform.rotation,
				scaleWS = transform.lossyScale,
				mesh = PortalCoreUtil.cube
			};
		}

		// -------------------------------------------------- //
        //                       GIZMOS                       //
        // -------------------------------------------------- //

#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
			Gizmos.DrawIcon(transform.position, "kTools/Portals/PortalOccluder icon.png", true);
			PortalDebugUtil.DrawCube(transform.position, transform.rotation, transform.lossyScale, PortalDebugColors.occluder);
        }
#endif
	}
}
