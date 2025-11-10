using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for segment_configurations in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxDataviewSegmentConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// The db_paths attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbPaths is required")]
    public List<TerraformProperty<string>>? DbPaths
    {
        get => GetProperty<List<TerraformProperty<string>>>("db_paths");
        set => WithProperty("db_paths", value);
    }

    /// <summary>
    /// The on_demand attribute.
    /// </summary>
    public TerraformProperty<bool>? OnDemand
    {
        get => GetProperty<TerraformProperty<bool>>("on_demand");
        set => WithProperty("on_demand", value);
    }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeName is required")]
    public required TerraformProperty<string> VolumeName
    {
        get => GetProperty<TerraformProperty<string>>("volume_name");
        set => WithProperty("volume_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFinspaceKxDataviewTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_finspace_kx_dataview resource.
/// </summary>
public class AwsFinspaceKxDataview : TerraformResource
{
    public AwsFinspaceKxDataview(string name) : base("aws_finspace_kx_dataview", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_timestamp");
        this.DeclareOutput("last_modified_timestamp");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The auto_update attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoUpdate is required")]
    public required TerraformProperty<bool> AutoUpdate
    {
        get => GetProperty<TerraformProperty<bool>>("auto_update");
        set => this.WithProperty("auto_update", value);
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZoneId
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone_id");
        set => this.WithProperty("availability_zone_id", value);
    }

    /// <summary>
    /// The az_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzMode is required")]
    public required TerraformProperty<string> AzMode
    {
        get => GetProperty<TerraformProperty<string>>("az_mode");
        set => this.WithProperty("az_mode", value);
    }

    /// <summary>
    /// The changeset_id attribute.
    /// </summary>
    public TerraformProperty<string>? ChangesetId
    {
        get => GetProperty<TerraformProperty<string>>("changeset_id");
        set => this.WithProperty("changeset_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentId is required")]
    public required TerraformProperty<string> EnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("environment_id");
        set => this.WithProperty("environment_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The read_write attribute.
    /// </summary>
    public TerraformProperty<bool>? ReadWrite
    {
        get => GetProperty<TerraformProperty<bool>>("read_write");
        set => this.WithProperty("read_write", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for segment_configurations.
    /// Nesting mode: list
    /// </summary>
    public List<AwsFinspaceKxDataviewSegmentConfigurationsBlock>? SegmentConfigurations
    {
        get => GetProperty<List<AwsFinspaceKxDataviewSegmentConfigurationsBlock>>("segment_configurations");
        set => this.WithProperty("segment_configurations", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFinspaceKxDataviewTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsFinspaceKxDataviewTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_timestamp attribute.
    /// </summary>
    public TerraformExpression CreatedTimestamp => this["created_timestamp"];

    /// <summary>
    /// The last_modified_timestamp attribute.
    /// </summary>
    public TerraformExpression LastModifiedTimestamp => this["last_modified_timestamp"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
