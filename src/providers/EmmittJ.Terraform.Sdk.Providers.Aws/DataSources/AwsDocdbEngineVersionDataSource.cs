using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_docdb_engine_version.
/// </summary>
public class AwsDocdbEngineVersionDataSource : TerraformDataSource
{
    public AwsDocdbEngineVersionDataSource(string name) : base("aws_docdb_engine_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("engine_description");
        SetOutput("exportable_log_types");
        SetOutput("supports_log_exports_to_cloudwatch");
        SetOutput("valid_upgrade_targets");
        SetOutput("version_description");
        SetOutput("engine");
        SetOutput("id");
        SetOutput("parameter_group_family");
        SetOutput("preferred_versions");
        SetOutput("region");
        SetOutput("version");
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string> Engine
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine");
        set => SetProperty("engine", value);
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
    /// The parameter_group_family attribute.
    /// </summary>
    public TerraformProperty<string> ParameterGroupFamily
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parameter_group_family");
        set => SetProperty("parameter_group_family", value);
    }

    /// <summary>
    /// The preferred_versions attribute.
    /// </summary>
    public List<TerraformProperty<string>> PreferredVersions
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("preferred_versions");
        set => SetProperty("preferred_versions", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// The engine_description attribute.
    /// </summary>
    public TerraformExpression EngineDescription => this["engine_description"];

    /// <summary>
    /// The exportable_log_types attribute.
    /// </summary>
    public TerraformExpression ExportableLogTypes => this["exportable_log_types"];

    /// <summary>
    /// The supports_log_exports_to_cloudwatch attribute.
    /// </summary>
    public TerraformExpression SupportsLogExportsToCloudwatch => this["supports_log_exports_to_cloudwatch"];

    /// <summary>
    /// The valid_upgrade_targets attribute.
    /// </summary>
    public TerraformExpression ValidUpgradeTargets => this["valid_upgrade_targets"];

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    public TerraformExpression VersionDescription => this["version_description"];

}
