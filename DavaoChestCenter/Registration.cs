using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DavaoChestCenter
{
    public partial class Registration : Form
    {
        public Registration()
        {<DirectedGraph xmlns="http://schemas.microsoft.com/vs/2009/dgml">
  <Nodes>
    <Node Id="(@1 @2)" Visibility="Hidden" />
    <Node Id="(@3 Namespace=DavaoChestCenter Type=formProfile)" Category="CodeSchema_Class" CodeSchemaProperty_IsPublic="True" CommonLabel="formProfile" Icon="Microsoft.VisualStudio.Class.Public" IsDragSource="True" Label="formProfile" SourceLocation="(Assembly=&quot;file:///C:/Users/cevcrumb/Documents/Visual Studio 2015/Projects/davchest/DavaoChestCenter/formProfile.cs&quot; StartLineNumber=13 StartCharacterOffset=25 EndLineNumber=13 EndCharacterOffset=36)" />
  </Nodes>
  <Links>
    <Link Source="(@1 @2)" Target="(@3 Namespace=DavaoChestCenter Type=formProfile)" Category="Contains" />
  </Links>
  <Categories>
    <Category Id="CodeSchema_Class" Label="Class" BasedOn="CodeSchema_Type" Icon="CodeSchema_Class" />
    <Category Id="CodeSchema_Type" Label="Type" Icon="CodeSchema_Class" />
    <Category Id="Contains" Label="Contains" Description="Whether the source of the link contains the target object" IsContainment="True" />
  </Categories>
  <Properties>
    <Property Id="CodeSchemaProperty_IsPublic" Label="Is Public" Description="Flag to indicate the scope is Public" DataType="System.Boolean" />
    <Property Id="CommonLabel" DataType="System.String" />
    <Property Id="Icon" Label="Icon" DataType="System.String" />
    <Property Id="IsContainment" DataType="System.Boolean" />
    <Property Id="IsDragSource" Label="IsDragSource" Description="IsDragSource" DataType="System.Boolean" />
    <Property Id="Label" Label="Label" Description="Displayable label of an Annotatable object" DataType="System.String" />
    <Property Id="SourceLocation" Label="Start Line Number" DataType="Microsoft.VisualStudio.GraphModel.CodeSchema.SourceLocation" />
    <Property Id="Visibility" Label="Visibility" Description="Defines whether a node in the graph is visible or not" DataType="System.Windows.Visibility" />
  </Properties>
  <QualifiedNames>
    <Name Id="Assembly" Label="Assembly" ValueType="Uri" />
    <Name Id="File" Label="File" ValueType="Uri" />
    <Name Id="Namespace" Label="Namespace" ValueType="System.String" />
    <Name Id="Type" Label="Type" ValueType="System.Object" />
  </QualifiedNames>
  <IdentifierAliases>
    <Alias n="1" Uri="Assembly=$(VsSolutionUri)/DavaoChestCenter/DavaoChestCenter.csproj" />
    <Alias n="2" Uri="File=$(VsSolutionUri)/DavaoChestCenter/formProfile.cs" />
    <Alias n="3" Uri="Assembly=$(f160bad3-8a6c-4052-bb43-9466cc345c67.OutputPathUri)" />
  </IdentifierAliases>
  <Paths>
    <Path Id="f160bad3-8a6c-4052-bb43-9466cc345c67.OutputPathUri" Value="file:///C:/Users/cevcrumb/Documents/Visual Studio 2015/Projects/davchest/DavaoChestCenter/bin/Debug/DavaoChestCenter.exe" />
    <Path Id="VsSolutionUri" Value="file:///C:/Users/cevcrumb/Documents/Visual Studio 2015/Projects/davchest" />
  </Paths>
</DirectedGraph>
            InitializeComponent();
        }
    }
}
