using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rum_metrics_destination resource.
/// </summary>
public class AwsRumMetricsDestination : TerraformResource
{
    public AwsRumMetricsDestination(string name) : base("aws_rum_metrics_destination", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("app_monitor_name");
        SetOutput("destination");
        SetOutput("destination_arn");
        SetOutput("iam_role_arn");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The app_monitor_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppMonitorName is required")]
    public required TerraformProperty<string> AppMonitorName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_monitor_name");
        set => SetProperty("app_monitor_name", value);
    }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformProperty<string> Destination
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination");
        set => SetProperty("destination", value);
    }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    public TerraformProperty<string> DestinationArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_arn");
        set => SetProperty("destination_arn", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> IamRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_role_arn");
        set => SetProperty("iam_role_arn", value);
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
