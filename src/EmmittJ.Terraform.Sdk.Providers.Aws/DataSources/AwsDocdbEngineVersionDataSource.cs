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
        this.DeclareOutput("engine_description");
        this.DeclareOutput("exportable_log_types");
        this.DeclareOutput("supports_log_exports_to_cloudwatch");
        this.DeclareOutput("valid_upgrade_targets");
        this.DeclareOutput("version_description");
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string>? Engine
    {
        get => GetProperty<TerraformProperty<string>>("engine");
        set => this.WithProperty("engine", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The parameter_group_family attribute.
    /// </summary>
    public TerraformProperty<string>? ParameterGroupFamily
    {
        get => GetProperty<TerraformProperty<string>>("parameter_group_family");
        set => this.WithProperty("parameter_group_family", value);
    }

    /// <summary>
    /// The preferred_versions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PreferredVersions
    {
        get => GetProperty<List<TerraformProperty<string>>>("preferred_versions");
        set => this.WithProperty("preferred_versions", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
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
