using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsIdentitySourceConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_verifiedpermissions_identity_source resource.
/// </summary>
public class AwsVerifiedpermissionsIdentitySource : TerraformResource
{
    public AwsVerifiedpermissionsIdentitySource(string name) : base("aws_verifiedpermissions_identity_source", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyStoreId is required")]
    public required TerraformProperty<string> PolicyStoreId
    {
        get => GetProperty<TerraformProperty<string>>("policy_store_id");
        set => this.WithProperty("policy_store_id", value);
    }

    /// <summary>
    /// The principal_entity_type attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalEntityType
    {
        get => GetProperty<TerraformProperty<string>>("principal_entity_type");
        set => this.WithProperty("principal_entity_type", value);
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
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsVerifiedpermissionsIdentitySourceConfigurationBlock>? Configuration
    {
        get => GetProperty<List<AwsVerifiedpermissionsIdentitySourceConfigurationBlock>>("configuration");
        set => this.WithProperty("configuration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
