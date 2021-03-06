using System;
using UnityEngine;

namespace WellFired
{
	[USequencerEvent("Sequence/Play uSequence"), USequencerFriendlyName("Play uSequence")]
	public class USPlaySequenceEvent : USEventBase
	{
		public USSequencer sequence;

		public bool restartSequencer;

		public override void FireEvent()
		{
			if (!this.sequence)
			{
				Debug.LogWarning("No sequence for USPlaySequenceEvent : " + base.name, this);
				return;
			}
			if (!Application.isPlaying)
			{
				Debug.LogWarning("Sequence playback controls are not supported in the editor, but will work in game, just fine.");
				return;
			}
			if (!this.restartSequencer)
			{
				this.sequence.Play();
			}
			else
			{
				this.sequence.RunningTime = 0f;
				this.sequence.Play();
			}
		}

		public override void ProcessEvent(float deltaTime)
		{
		}
	}
}
