using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_docdb_engine_version Terraform data source.
/// Retrieves information about a aws_docdb_engine_version.
/// </summary>
public partial class AwsDocdbEngineVersionDataSource(string name) : TerraformDataSource("aws_docdb_engine_version", name)
{
    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string>? Engine
    {
        get => new TerraformReference<string>(this, "engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The parameter_group_family attribute.
    /// </summary>
    public TerraformValue<string> ParameterGroupFamily
    {
        get => new TerraformReference<string>(this, "parameter_group_family");
        set => SetArgument("parameter_group_family", value);
    }

    /// <summary>
    /// The preferred_versions attribute.
    /// </summary>
    public TerraformList<string>? PreferredVersions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "preferred_versions").ResolveNodes(ctx));
        set => SetArgument("preferred_versions", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The engine_description attribute.
    /// </summary>
    public TerraformValue<string> EngineDescription
    {
        get => new TerraformReference<string>(this, "engine_description");
    }

    /// <summary>
    /// The exportable_log_types attribute.
    /// </summary>
    public TerraformSet<string> ExportableLogTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "exportable_log_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The supports_log_exports_to_cloudwatch attribute.
    /// </summary>
    public TerraformValue<bool> SupportsLogExportsToCloudwatch
    {
        get => new TerraformReference<bool>(this, "supports_log_exports_to_cloudwatch");
    }

    /// <summary>
    /// The valid_upgrade_targets attribute.
    /// </summary>
    public TerraformSet<string> ValidUpgradeTargets
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "valid_upgrade_targets").ResolveNodes(ctx));
    }

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    public TerraformValue<string> VersionDescription
    {
        get => new TerraformReference<string>(this, "version_description");
    }

}
