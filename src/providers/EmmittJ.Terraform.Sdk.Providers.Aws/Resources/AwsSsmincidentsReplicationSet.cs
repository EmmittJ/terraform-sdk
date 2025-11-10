using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for region in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsSsmincidentsReplicationSetRegionBlock : TerraformBlock
{
    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        set => SetProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        set => SetProperty("status", value);
    }

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformProperty<string>? StatusMessage
    {
        set => SetProperty("status_message", value);
    }

}

/// <summary>
/// Block type for regions in .
/// Nesting mode: set
/// </summary>
public class AwsSsmincidentsReplicationSetRegionsBlock : TerraformBlock
{
    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        set => SetProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        set => SetProperty("status", value);
    }

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    public TerraformProperty<string>? StatusMessage
    {
        set => SetProperty("status_message", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSsmincidentsReplicationSetTimeoutsBlock : TerraformBlock
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
/// Manages a aws_ssmincidents_replication_set resource.
/// </summary>
public class AwsSsmincidentsReplicationSet : TerraformResource
{
    public AwsSsmincidentsReplicationSet(string name) : base("aws_ssmincidents_replication_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("created_by");
        SetOutput("deletion_protected");
        SetOutput("last_modified_by");
        SetOutput("status");
        SetOutput("id");
        SetOutput("tags");
        SetOutput("tags_all");
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
    /// Block for region.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public HashSet<AwsSsmincidentsReplicationSetRegionBlock>? Region
    {
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for regions.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSsmincidentsReplicationSetRegionsBlock>? Regions
    {
        set => SetProperty("regions", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsSsmincidentsReplicationSetTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformExpression CreatedBy => this["created_by"];

    /// <summary>
    /// The deletion_protected attribute.
    /// </summary>
    public TerraformExpression DeletionProtected => this["deletion_protected"];

    /// <summary>
    /// The last_modified_by attribute.
    /// </summary>
    public TerraformExpression LastModifiedBy => this["last_modified_by"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
