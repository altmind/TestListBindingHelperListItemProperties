using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestListBindingHelperListItemProperties
{
    class Program
    {
        /**
         Mono Output:
StructLayoutAttribute: System.Runtime.InteropServices.StructLayoutAttribute, Con
tainsGenericParameters: System.Boolean, GUID: System.Guid, DeclaringMethod: Syst
em.Reflection.MethodBase, AssemblyQualifiedName: System.String, DeclaringType: S
ystem.Type, Name: System.String, Namespace: System.String, IsSecurityTransparent
: System.Boolean, IsSecurityCritical: System.Boolean, IsSecuritySafeCritical: Sy
stem.Boolean, FullName: System.String, Module: System.Reflection.Module, Assembl
y: System.Reflection.Assembly, TypeHandle: System.RuntimeTypeHandle, BaseType: S
ystem.Type, UnderlyingSystemType: System.Type, IsEnum: System.Boolean, GenericPa
rameterAttributes: System.Reflection.GenericParameterAttributes, IsGenericTypeDe
finition: System.Boolean, IsGenericParameter: System.Boolean, GenericParameterPo
sition: System.Int32, IsGenericType: System.Boolean, IsConstructedGenericType: S
ystem.Boolean, MemberType: System.Reflection.MemberTypes, ReflectedType: System.
Type, MetadataToken: System.Int32, GenericTypeParameters: System.Type[], Declare
dConstructors: System.Collections.Generic.IEnumerable`1[System.Reflection.Constr
uctorInfo], DeclaredEvents: System.Collections.Generic.IEnumerable`1[System.Refl
ection.EventInfo], DeclaredFields: System.Collections.Generic.IEnumerable`1[Syst
em.Reflection.FieldInfo], DeclaredMembers: System.Collections.Generic.IEnumerabl
e`1[System.Reflection.MemberInfo], DeclaredMethods: System.Collections.Generic.I
Enumerable`1[System.Reflection.MethodInfo], DeclaredNestedTypes: System.Collecti
ons.Generic.IEnumerable`1[System.Reflection.TypeInfo], DeclaredProperties: Syste
m.Collections.Generic.IEnumerable`1[System.Reflection.PropertyInfo], Implemented
Interfaces: System.Collections.Generic.IEnumerable`1[System.Type], TypeInitializ
er: System.Reflection.ConstructorInfo, IsNested: System.Boolean, Attributes: Sys
tem.Reflection.TypeAttributes, IsVisible: System.Boolean, IsNotPublic: System.Bo
olean, IsPublic: System.Boolean, IsNestedPublic: System.Boolean, IsNestedPrivate
: System.Boolean, IsNestedFamily: System.Boolean, IsNestedAssembly: System.Boole
an, IsNestedFamANDAssem: System.Boolean, IsNestedFamORAssem: System.Boolean, IsA
utoLayout: System.Boolean, IsLayoutSequential: System.Boolean, IsExplicitLayout:
 System.Boolean, IsClass: System.Boolean, IsInterface: System.Boolean, IsValueTy
pe: System.Boolean, IsAbstract: System.Boolean, IsSealed: System.Boolean, IsSpec
ialName: System.Boolean, IsImport: System.Boolean, IsSerializable: System.Boolea
n, IsAnsiClass: System.Boolean, IsUnicodeClass: System.Boolean, IsAutoClass: Sys
tem.Boolean, IsArray: System.Boolean, IsByRef: System.Boolean, IsPointer: System
.Boolean, IsPrimitive: System.Boolean, IsCOMObject: System.Boolean, HasElementTy
pe: System.Boolean, IsContextful: System.Boolean, IsMarshalByRef: System.Boolean
, GenericTypeArguments: System.Type[], CustomAttributes: System.Collections.Gene
ric.IEnumerable`1[System.Reflection.CustomAttributeData]

.NET output:
    BuysPrice: System.String,
*/
        static void Main(string[] args)
        {
            PropertyDescriptorCollection originalProps = System.Windows.Forms.ListBindingHelper.GetListItemProperties(typeof(AdaptedOrder), null);
            string res = "";
            for (int i = 0; i < originalProps.Count; i++)
            {
                res += originalProps[i].Name + ": " + originalProps[i].PropertyType.ToString() + ", ";
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
