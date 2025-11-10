using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3control_access_point_policy resource.
/// </summary>
public class AwsS3controlAccessPointPolicy : TerraformResource
{
    public AwsS3controlAccessPointPolicy(string name) : base("aws_s3control_access_point_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("has_public_access_policy");
        SetOutput("access_point_arn");
        SetOutput("id");
        SetOutput("policy");
        SetOutput("region");
    }

    /// <summary>
    /// The access_point_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPointArn is required")]
    public required TerraformProperty<string> AccessPointArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_point_arn");
        set => SetProperty("access_point_arn", value);
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
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformProperty<string> Policy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy");
        set => SetProperty("policy", value);
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
    /// The has_public_access_policy attribute.
    /// </summary>
    public TerraformExpression HasPublicAccessPolicy => this["has_public_access_policy"];

}
