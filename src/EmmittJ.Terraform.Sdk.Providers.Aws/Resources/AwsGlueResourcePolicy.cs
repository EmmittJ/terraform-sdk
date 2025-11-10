using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_glue_resource_policy resource.
/// </summary>
public class AwsGlueResourcePolicy : TerraformResource
{
    public AwsGlueResourcePolicy(string name) : base("aws_glue_resource_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The enable_hybrid attribute.
    /// </summary>
    public TerraformProperty<string>? EnableHybrid
    {
        get => GetProperty<TerraformProperty<string>>("enable_hybrid");
        set => this.WithProperty("enable_hybrid", value);
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
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformProperty<string> Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => this.WithProperty("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
