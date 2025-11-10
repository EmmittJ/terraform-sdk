using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_log_index_policy resource.
/// </summary>
public class AwsCloudwatchLogIndexPolicy : TerraformResource
{
    public AwsCloudwatchLogIndexPolicy(string name) : base("aws_cloudwatch_log_index_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    public required TerraformProperty<string> LogGroupName
    {
        get => GetProperty<TerraformProperty<string>>("log_group_name");
        set => this.WithProperty("log_group_name", value);
    }

    /// <summary>
    /// Field index filter policy, in JSON
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDocument is required")]
    public required TerraformProperty<string> PolicyDocument
    {
        get => GetProperty<TerraformProperty<string>>("policy_document");
        set => this.WithProperty("policy_document", value);
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
