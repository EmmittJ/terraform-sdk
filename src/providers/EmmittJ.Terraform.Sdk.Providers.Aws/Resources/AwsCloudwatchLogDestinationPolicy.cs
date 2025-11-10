using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_log_destination_policy resource.
/// </summary>
public class AwsCloudwatchLogDestinationPolicy : TerraformResource
{
    public AwsCloudwatchLogDestinationPolicy(string name) : base("aws_cloudwatch_log_destination_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("access_policy");
        SetOutput("destination_name");
        SetOutput("force_update");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPolicy is required")]
    public required TerraformProperty<string> AccessPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_policy");
        set => SetProperty("access_policy", value);
    }

    /// <summary>
    /// The destination_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationName is required")]
    public required TerraformProperty<string> DestinationName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_name");
        set => SetProperty("destination_name", value);
    }

    /// <summary>
    /// The force_update attribute.
    /// </summary>
    public TerraformProperty<bool> ForceUpdate
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_update");
        set => SetProperty("force_update", value);
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

}
