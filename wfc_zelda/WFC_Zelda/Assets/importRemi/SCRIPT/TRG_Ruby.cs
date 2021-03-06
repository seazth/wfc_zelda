﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRG_Ruby : TRG
{
    public int amount = 1;
    public override void trigger(Actor actor, Collider other)
    {
        if (actor is Player)
        {
            ((Player)actor).takeRuby(amount);
            Destroy(gameObject);
        }
    }
}
