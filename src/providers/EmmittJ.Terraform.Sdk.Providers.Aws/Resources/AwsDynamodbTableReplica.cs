using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDynamodbTableReplicaTimeoutsBlock : TerraformBlock
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
/// Manages a aws_dynamodb_table_replica resource.
/// </summary>
public class AwsDynamodbTableReplica : TerraformResource
{
    public AwsDynamodbTableReplica(string name) : base("aws_dynamodb_table_replica", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("deletion_protection_enabled");
        SetOutput("global_table_arn");
        SetOutput("id");
        SetOutput("kms_key_arn");
        SetOutput("point_in_time_recovery");
        SetOutput("region");
        SetOutput("table_class_override");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DeletionProtectionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection_enabled");
        set => SetProperty("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The global_table_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalTableArn is required")]
    public required TerraformProperty<string> GlobalTableArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("global_table_arn");
        set => SetProperty("global_table_arn", value);
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
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_arn");
        set => SetProperty("kms_key_arn", value);
    }

    /// <summary>
    /// The point_in_time_recovery attribute.
    /// </summary>
    public TerraformProperty<bool> PointInTimeRecovery
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("point_in_time_recovery");
        set => SetProperty("point_in_time_recovery", value);
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
    /// The table_class_override attribute.
    /// </summary>
    public TerraformProperty<string> TableClassOverride
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table_class_override");
        set => SetProperty("table_class_override", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDynamodbTableReplicaTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
