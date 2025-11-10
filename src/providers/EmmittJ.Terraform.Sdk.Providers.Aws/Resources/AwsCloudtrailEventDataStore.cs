using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for advanced_event_selector in .
/// Nesting mode: list
/// </summary>
public class AwsCloudtrailEventDataStoreAdvancedEventSelectorBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudtrailEventDataStoreTimeoutsBlock : TerraformBlock
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
/// Manages a aws_cloudtrail_event_data_store resource.
/// </summary>
public class AwsCloudtrailEventDataStore : TerraformResource
{
    public AwsCloudtrailEventDataStore(string name) : base("aws_cloudtrail_event_data_store", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("billing_mode");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("multi_region_enabled");
        SetOutput("name");
        SetOutput("organization_enabled");
        SetOutput("region");
        SetOutput("retention_period");
        SetOutput("suspend");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("termination_protection_enabled");
    }

    /// <summary>
    /// The billing_mode attribute.
    /// </summary>
    public TerraformProperty<string> BillingMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("billing_mode");
        set => SetProperty("billing_mode", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The multi_region_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> MultiRegionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("multi_region_enabled");
        set => SetProperty("multi_region_enabled", value);
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
    /// The organization_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> OrganizationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("organization_enabled");
        set => SetProperty("organization_enabled", value);
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
    /// The retention_period attribute.
    /// </summary>
    public TerraformProperty<double> RetentionPeriod
    {
        get => GetRequiredOutput<TerraformProperty<double>>("retention_period");
        set => SetProperty("retention_period", value);
    }

    /// <summary>
    /// The suspend attribute.
    /// </summary>
    public TerraformProperty<string> Suspend
    {
        get => GetRequiredOutput<TerraformProperty<string>>("suspend");
        set => SetProperty("suspend", value);
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
    /// The termination_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> TerminationProtectionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("termination_protection_enabled");
        set => SetProperty("termination_protection_enabled", value);
    }

    /// <summary>
    /// Block for advanced_event_selector.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCloudtrailEventDataStoreAdvancedEventSelectorBlock>? AdvancedEventSelector
    {
        set => SetProperty("advanced_event_selector", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCloudtrailEventDataStoreTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
