﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Construct.Utilities
{
    /// <summary>
    /// Keeps track of instructions that belong to one scene/training unit.
    /// </summary>
    public class InstructionSet : MonoBehaviour
    {
        #region VAR
        public List<Instruction> Instructions;

        public Instruction currentInstruction;
        #endregion

        private void Start()
        {
            Initialise();   
        }

        private void Initialise() 
        {
            if (Instructions.Count > 0)
            {
                currentInstruction = Instructions[0];
            }
        }

        public Instruction LoadNextInstruction() 
        {
            currentInstruction =  DataStructHelper.nextElementInList<Instruction>(Instructions, currentInstruction);
            return currentInstruction;
        }
        public Instruction LoadPreviousInstruction() 
        {
            currentInstruction = DataStructHelper.previousElementInList<Instruction>(Instructions, currentInstruction);
            return currentInstruction;
        }
        public Instruction ReloadCurrentInstruction() 
        {
            //Obsolete, TODO replay/display again instruction
            //currentInstruction = Instructions[0];
            return currentInstruction;
        }

        public void ResetInstructions() 
        {
            currentInstruction = Instructions[0];
        }

    }

}
