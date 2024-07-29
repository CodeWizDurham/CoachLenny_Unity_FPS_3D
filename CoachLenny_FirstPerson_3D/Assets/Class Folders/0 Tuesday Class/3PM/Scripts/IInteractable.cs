using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An interface in programming is like a contract. 
/// Everything within the contract no matter 
/// what when it is called on in a class
/// all the contents within that contract must be implemented!
/// </summary>
public interface IInteractable
{
    //Everything in here will be added to the script it is applied to
    void Interact();
}
