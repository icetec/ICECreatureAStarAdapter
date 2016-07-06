// ##############################################################################
//
// ICECreatureAstarAdapterEditor.cs
// Version 1.1.21
//
// © Pit Vetterick, ICE Technologies Consulting LTD. All Rights Reserved.
// http://www.ice-technologies.com
// mailto:support@ice-technologies.com
// 
// Unity Asset Store End User License Agreement (EULA)
// http://unity3d.com/legal/as_terms
//
// ##############################################################################

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEditor.AnimatedValues;

using ICE;
using ICE.World;
using ICE.World.EditorUtilities;

using ICE.Creatures;


namespace ICE.Creatures.Adapter
{
	[CustomEditor(typeof(ICECreatureAstarAdapter))]
	public class ICECreatureAstarAdapterEditor : Editor {

		public override void OnInspectorGUI()
		{
			ICECreatureAstarAdapter _adapter = (ICECreatureAstarAdapter)target;
			//ICECreatureControl _control = _adapter.GetComponent<ICECreatureControl>();	
			
			EditorGUILayout.Separator();	

			_adapter.RepathRate = ICEEditorLayout.DefaultSlider( "Repath Rate", "", _adapter.RepathRate, 0.05f, 0, 10, 0.5f );
			_adapter.SlowdownDistance = ICEEditorLayout.DefaultSlider( "Slowdown Distance", "", _adapter.SlowdownDistance, 0.05f, 0, 10, 0.6f );
			_adapter.PickNextWaypointDist = ICEEditorLayout.DefaultSlider( "PickNextWaypointDist", "", _adapter.PickNextWaypointDist, 0.05f, 0, 10, 2 );
			_adapter.ForwardLook = ICEEditorLayout.DefaultSlider( "ForwardLook", "", _adapter.ForwardLook, 0.05f, 0, 10, 1 );
			_adapter.EndReachedDistance = ICEEditorLayout.DefaultSlider( "EndReachedDistance", "", _adapter.EndReachedDistance, 0.05f, 0, 10, 0.2F );

			_adapter.CanMove = ICEEditorLayout.Toggle( "Can Move", "Enables or disables movement", _adapter.CanMove, "" );
			_adapter.CanSearch = ICEEditorLayout.Toggle( "Can Search", "Enables or disables searching for paths", _adapter.CanSearch, "" );
			_adapter.ClosestOnPathCheck = ICEEditorLayout.Toggle( "ClosestOnPathCheck", "Enables or disables searching for paths", _adapter.ClosestOnPathCheck, "" );



			/*
			ICEEditorLayout.Label("Creature Damage", true );
			EditorGUI.indentLevel++;
			_adapter.BehaviourModeKey = EditorBehaviour.BehaviourSelect( _control, "Behaviour", "", _adapter.BehaviourModeKey , "IMPACT" );
			
			_adapter.UseAdvanced = ICEEditorLayout.Toggle( "Advanced Influences", "", _adapter.UseAdvanced, "" );
			EditorGUI.BeginDisabledGroup( _adapter.UseAdvanced == false );
			EditorGUI.indentLevel++;			
			_adapter.InfluenceDamage = ICEEditorLayout.Slider( "Damage", "", _adapter.InfluenceDamage, 0.05f, -100, 100 );		
			_adapter.InfluenceStress = ICEEditorLayout.Slider( "Stress", "", _adapter.InfluenceStress, 0.05f, -100, 100 );
			_adapter.InfluenceDebility = ICEEditorLayout.Slider( "Debility", "", _adapter.InfluenceDebility, 0.05f, -100, 100 );
			_adapter.InfluenceHunger = ICEEditorLayout.Slider( "Hunger", "", _adapter.InfluenceHunger, 0.05f, -100, 100 );			
			_adapter.InfluenceThirst = ICEEditorLayout.Slider( "Thirst", "", _adapter.InfluenceThirst, 0.05f, -100, 100 );				
			EditorGUI.indentLevel--;
			EditorGUI.EndDisabledGroup();	
			EditorGUI.indentLevel--;
			EditorGUILayout.Separator();
			
			EditorGUILayout.Separator();
			
			_adapter.UsePlayerDamage = ICEEditorLayout.ToggleLeft( "Player Damage", "", _adapter.UsePlayerDamage, true );
			EditorGUI.BeginDisabledGroup( _adapter.UsePlayerDamage == false );
			EditorGUI.indentLevel++;	
			_adapter.PlayerDamage = ICEEditorLayout.Slider( "Damage", "", _adapter.PlayerDamage, 0.05f, 0, 100 );	
			EditorGUILayout.Separator();
			_adapter.PlayerDamageBehaviourModeKey = EditorBehaviour.BehaviourSelect( _control, "Trigger Behaviour", "", _adapter.PlayerDamageBehaviourModeKey , "ATTACK" );
			_adapter.PlayerDamageRange = ICEEditorLayout.Slider( "Trigger Range", "", _adapter.PlayerDamageRange, 0.05f, 0, 10 );
			_adapter.PlayerDamageInterval = ICEEditorLayout.Slider( "Trigger Interval", "", _adapter.PlayerDamageInterval, 0.05f, 0, 10 );
			EditorGUI.indentLevel--;
			EditorGUI.EndDisabledGroup();			
			EditorGUILayout.Separator();*/
			
		}
	}
}
