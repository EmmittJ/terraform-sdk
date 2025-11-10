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
        SetOutput("last_modified");
        SetOutput("arn");
        SetOutput("hybrid_access_enabled");
        SetOutput("id");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("use_service_linked_role");
        SetOutput("with_federation");
        SetOutput("with_privileged_access");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The hybrid_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> HybridAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("hybrid_access_enabled");
        set => SetProperty("hybrid_access_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The use_service_linked_role attribute.
    /// </summary>
    public TerraformProperty<bool> UseServiceLinkedRole
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_service_linked_role");
        set => SetProperty("use_service_linked_role", value);
    }

    /// <summary>
    /// The with_federation attribute.
    /// </summary>
    public TerraformProperty<bool> WithFederation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("with_federation");
        set => SetProperty("with_federation", value);
    }

    /// <summary>
    /// The with_privileged_access attribute.
    /// </summary>
    public TerraformProperty<bool> WithPrivilegedAccess
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("with_privileged_access");
        set => SetProperty("with_privileged_access", value);
    }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformExpression LastModified => this["last_modified"];

}
