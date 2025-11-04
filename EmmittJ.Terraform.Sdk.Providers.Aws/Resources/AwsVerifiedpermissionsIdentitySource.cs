using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? PolicyStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_store_id")?.Value;
        set => this.WithProperty("policy_store_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The principal_entity_type attribute.
    /// </summary>
    public string? PrincipalEntityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_entity_type")?.Value;
        set => this.WithProperty("principal_entity_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
