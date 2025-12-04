using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for trace_configuration in AwsApprunnerObservabilityConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsApprunnerObservabilityConfigurationTraceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trace_configuration";

    /// <summary>
    /// The vendor attribute.
    /// </summary>
    public TerraformValue<string>? Vendor
    {
        get => GetArgument<TerraformValue<string>>("vendor");
        set => SetArgument("vendor", value);
    }

}


/// <summary>
/// Represents a aws_apprunner_observability_configuration Terraform resource.
/// Manages a aws_apprunner_observability_configuration resource.
/// </summary>
public partial class AwsApprunnerObservabilityConfiguration(string name) : TerraformResource("aws_apprunner_observability_configuration", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The observability_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObservabilityConfigurationName is required")]
    public required TerraformValue<string> ObservabilityConfigurationName
    {
        get => GetArgument<TerraformValue<string>>("observability_configuration_name");
        set => SetArgument("observability_configuration_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The latest attribute.
    /// </summary>
    public TerraformValue<bool> Latest
        => AsReference("latest");

    /// <summary>
    /// The observability_configuration_revision attribute.
    /// </summary>
    public TerraformValue<double> ObservabilityConfigurationRevision
        => AsReference("observability_configuration_revision");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// TraceConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TraceConfiguration block(s) allowed")]
    public TerraformList<AwsApprunnerObservabilityConfigurationTraceConfigurationBlock>? TraceConfiguration
    {
        get => GetArgument<TerraformList<AwsApprunnerObservabilityConfigurationTraceConfigurationBlock>>("trace_configuration");
        set => SetArgument("trace_configuration", value);
    }

}
