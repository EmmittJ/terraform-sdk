using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lakeformation_resource resource.
/// </summary>
public class AwsLakeformationResource : TerraformResource
{
    public AwsLakeformationResource(string name) : base("aws_lakeformation_resource", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("last_modified");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn");
        set => this.WithProperty("arn", value);
    }

    /// <summary>
    /// The hybrid_access_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? HybridAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("hybrid_access_enabled");
        set => this.WithProperty("hybrid_access_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The use_service_linked_role attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? UseServiceLinkedRole
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_service_linked_role");
        set => this.WithProperty("use_service_linked_role", value);
    }

    /// <summary>
    /// The with_federation attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? WithFederation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("with_federation");
        set => this.WithProperty("with_federation", value);
    }

    /// <summary>
    /// The with_privileged_access attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? WithPrivilegedAccess
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("with_privileged_access");
        set => this.WithProperty("with_privileged_access", value);
    }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformExpression LastModified => this["last_modified"];

}
