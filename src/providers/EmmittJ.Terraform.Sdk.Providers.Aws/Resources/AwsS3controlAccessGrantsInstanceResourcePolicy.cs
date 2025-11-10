using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3control_access_grants_instance_resource_policy resource.
/// </summary>
public class AwsS3controlAccessGrantsInstanceResourcePolicy : TerraformResource
{
    public AwsS3controlAccessGrantsInstanceResourcePolicy(string name) : base("aws_s3control_access_grants_instance_resource_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("account_id");
        SetOutput("policy");
        SetOutput("region");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string> AccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_id");
        set => SetProperty("account_id", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
