#region license
// boo - an extensible programming language for the CLI
// Copyright (C) 2004 Rodrigo B. de Oliveira
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// As a special exception, if you link this library with other files to
// produce an executable, this library does not by itself cause the
// resulting executable to be covered by the GNU General Public License.
// This exception does not however invalidate any other reasons why the
// executable file might be covered by the GNU General Public License.
//
// Contact Information
//
// mailto:rbo@acm.org
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by the
// ast.py script on Wed Feb 11 16:46:00 2004
//
using System;

namespace Boo.Lang.Ast.Impl
{
	[Serializable]
	public abstract class ConstructorImpl : Method
	{
		
		protected ConstructorImpl()
		{
 		}
		
		protected ConstructorImpl(LexicalInfo lexicalInfo) : base(lexicalInfo)
		{
 		}
		
		public override NodeType NodeType
		{
			get
			{
				return NodeType.Constructor;
			}
		}
		new public Constructor CloneNode()
		{
			return (Constructor)Clone();
		}
		
		override public object Clone()
		{
			Constructor clone = (Constructor)System.Runtime.Serialization.FormatterServices.GetUninitializedObject(GetType());
			clone._lexicalInfo = _lexicalInfo;
			clone._documentation = _documentation;
			clone._properties = (System.Collections.Hashtable)_properties.Clone();
			
			clone._modifiers = _modifiers;
			clone._name = _name;
			if (null != _attributes)
			{
				clone._attributes = (AttributeCollection)_attributes.Clone();
			}
			if (null != _parameters)
			{
				clone._parameters = (ParameterDeclarationCollection)_parameters.Clone();
			}
			if (null != _returnType)
			{
				clone._returnType = (TypeReference)_returnType.Clone();
			}
			if (null != _returnTypeAttributes)
			{
				clone._returnTypeAttributes = (AttributeCollection)_returnTypeAttributes.Clone();
			}
			if (null != _body)
			{
				clone._body = (Block)_body.Clone();
			}
			if (null != _locals)
			{
				clone._locals = (LocalCollection)_locals.Clone();
			}
			
			return clone;
		}
		
		override public bool Replace(Node existing, Node newNode)
		{
			if (base.Replace(existing, newNode))
			{
				return true;
			}
			
			if (_attributes != null)
			{
				Attribute item = existing as Attribute;
				if (null != item)
				{
					if (_attributes.Replace(item, (Attribute)newNode))
					{
						return true;
					}
				}
			}
			if (_parameters != null)
			{
				ParameterDeclaration item = existing as ParameterDeclaration;
				if (null != item)
				{
					if (_parameters.Replace(item, (ParameterDeclaration)newNode))
					{
						return true;
					}
				}
			}
			if (_returnType == existing)
			{
				this.ReturnType = (TypeReference)newNode;
				return true;
			}
			if (_returnTypeAttributes != null)
			{
				Attribute item = existing as Attribute;
				if (null != item)
				{
					if (_returnTypeAttributes.Replace(item, (Attribute)newNode))
					{
						return true;
					}
				}
			}
			if (_body == existing)
			{
				this.Body = (Block)newNode;
				return true;
			}
			if (_locals != null)
			{
				Local item = existing as Local;
				if (null != item)
				{
					if (_locals.Replace(item, (Local)newNode))
					{
						return true;
					}
				}
			}
			return false;
		}
		
		override public void Switch(IAstTransformer transformer, out Node resultingNode)
		{
			Constructor thisNode = (Constructor)this;
			Constructor resultingTypedNode = thisNode;
			transformer.OnConstructor(thisNode, ref resultingTypedNode);
			resultingNode = resultingTypedNode;
		}
	}
}
