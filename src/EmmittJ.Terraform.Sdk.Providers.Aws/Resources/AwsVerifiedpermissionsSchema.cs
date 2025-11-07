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
    public TerraformProperty<string>? PolicyStoreId
    {
        get => GetProperty<TerraformProperty<string>>("policy_store_id");
        set => this.WithProperty("policy_store_id", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The namespaces attribute.
    /// </summary>
    public TerraformExpression Namespaces => this["namespaces"];

}
