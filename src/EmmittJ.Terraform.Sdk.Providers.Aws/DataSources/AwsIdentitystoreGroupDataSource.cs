using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alternate_identifier in .
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreGroupDataSourceAlternateIdentifierBlock : TerraformBlock
{
}

/// <summary>
/// Retrieves information about a aws_identitystore_group.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsIdentitystoreGroupDataSource : TerraformDataSource
{
    public AwsIdentitystoreGroupDataSource(string name) : base("aws_identitystore_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("display_name");
        this.DeclareOutput("external_ids");
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    public TerraformProperty<string>? GroupId
    {
        get => GetProperty<TerraformProperty<string>>("group_id");
        set => this.WithProperty("group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    public required TerraformProperty<string> IdentityStoreId
    {
        get => GetProperty<TerraformProperty<string>>("identity_store_id");
        set => this.WithProperty("identity_store_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for alternate_identifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlternateIdentifier block(s) allowed")]
    public List<AwsIdentitystoreGroupDataSourceAlternateIdentifierBlock>? AlternateIdentifier
    {
        get => GetProperty<List<AwsIdentitystoreGroupDataSourceAlternateIdentifierBlock>>("alternate_identifier");
        set => this.WithProperty("alternate_identifier", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The external_ids attribute.
    /// </summary>
    public TerraformExpression ExternalIds => this["external_ids"];

}
