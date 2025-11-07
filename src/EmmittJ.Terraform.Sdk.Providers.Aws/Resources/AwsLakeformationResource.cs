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
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
    }

    /// <summary>
    /// The hybrid_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HybridAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("hybrid_access_enabled");
        set => this.WithProperty("hybrid_access_enabled", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The use_service_linked_role attribute.
    /// </summary>
    public TerraformProperty<bool>? UseServiceLinkedRole
    {
        get => GetProperty<TerraformProperty<bool>>("use_service_linked_role");
        set => this.WithProperty("use_service_linked_role", value);
    }

    /// <summary>
    /// The with_federation attribute.
    /// </summary>
    public TerraformProperty<bool>? WithFederation
    {
        get => GetProperty<TerraformProperty<bool>>("with_federation");
        set => this.WithProperty("with_federation", value);
    }

    /// <summary>
    /// The with_privileged_access attribute.
    /// </summary>
    public TerraformProperty<bool>? WithPrivilegedAccess
    {
        get => GetProperty<TerraformProperty<bool>>("with_privileged_access");
        set => this.WithProperty("with_privileged_access", value);
    }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformExpression LastModified => this["last_modified"];

}
