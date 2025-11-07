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
    }

    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccessPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_policy");
        set => this.WithProperty("access_policy", value);
    }

    /// <summary>
    /// The destination_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DestinationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_name");
        set => this.WithProperty("destination_name", value);
    }

    /// <summary>
    /// The force_update attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ForceUpdate
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_update");
        set => this.WithProperty("force_update", value);
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

}
