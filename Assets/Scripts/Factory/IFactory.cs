﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Start is called before the first frame update
public interface IFactory
{
    GameObject FactoryMethod(int tag);
}

