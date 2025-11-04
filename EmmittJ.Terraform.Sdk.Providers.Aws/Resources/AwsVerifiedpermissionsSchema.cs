using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_verifiedpermissions_schema resource.
/// </summary>
public class AwsVerifiedpermissionsSchema : TerraformResource
{
    public AwsVerifiedpermissionsSchema(string name) : base("aws_verifiedpermissions_schema", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("namespaces");
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The namespaces attribute.
    /// </summary>
    public TerraformExpression Namespaces => this["namespaces"];

}
