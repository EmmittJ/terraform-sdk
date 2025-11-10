using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public class AwsPrometheusQueryLoggingConfigurationDestinationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsPrometheusQueryLoggingConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_prometheus_query_logging_configuration resource.
/// </summary>
public class AwsPrometheusQueryLoggingConfiguration : TerraformResource
{
    public AwsPrometheusQueryLoggingConfiguration(string name) : base("aws_prometheus_query_logging_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    public List<AwsPrometheusQueryLoggingConfigurationDestinationBlock>? Destination
    {
        get => GetProperty<List<AwsPrometheusQueryLoggingConfigurationDestinationBlock>>("destination");
        set => this.WithProperty("destination", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsPrometheusQueryLoggingConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsPrometheusQueryLoggingConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
