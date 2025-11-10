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
        set => SetProperty("db_paths", value);
    }

    /// <summary>
    /// The on_demand attribute.
    /// </summary>
    public TerraformProperty<bool>? OnDemand
    {
        set => SetProperty("on_demand", value);
    }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeName is required")]
    public required TerraformProperty<string> VolumeName
    {
        set => SetProperty("volume_name", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("created_timestamp");
        SetOutput("last_modified_timestamp");
        SetOutput("status");
        SetOutput("auto_update");
        SetOutput("availability_zone_id");
        SetOutput("az_mode");
        SetOutput("changeset_id");
        SetOutput("database_name");
        SetOutput("description");
        SetOutput("environment_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("read_write");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The auto_update attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoUpdate is required")]
    public required TerraformProperty<bool> AutoUpdate
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_update");
        set => SetProperty("auto_update", value);
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformProperty<string> AvailabilityZoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone_id");
        set => SetProperty("availability_zone_id", value);
    }

    /// <summary>
    /// The az_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzMode is required")]
    public required TerraformProperty<string> AzMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("az_mode");
        set => SetProperty("az_mode", value);
    }

    /// <summary>
    /// The changeset_id attribute.
    /// </summary>
    public TerraformProperty<string> ChangesetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("changeset_id");
        set => SetProperty("changeset_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_name");
        set => SetProperty("database_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentId is required")]
    public required TerraformProperty<string> EnvironmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("environment_id");
        set => SetProperty("environment_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The read_write attribute.
    /// </summary>
    public TerraformProperty<bool> ReadWrite
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("read_write");
        set => SetProperty("read_write", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for segment_configurations.
    /// Nesting mode: list
    /// </summary>
    public List<AwsFinspaceKxDataviewSegmentConfigurationsBlock>? SegmentConfigurations
    {
        set => SetProperty("segment_configurations", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFinspaceKxDataviewTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
