﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GraphProcessor;
using System.Linq;

[System.Serializable, NodeMenuItem("Custom/TextNode")]
public class TextNode : BaseNode
{
	[Output(name = "Label")]
	public string				output;

	public override string		name => "TextNode";

	[SerializeField]
	string						text = "";

	protected override void Process()
	{
	    output = text;
	}
}