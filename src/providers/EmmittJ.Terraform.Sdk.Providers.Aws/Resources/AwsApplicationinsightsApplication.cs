using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_applicationinsights_application resource.
/// </summary>
public class AwsApplicationinsightsApplication : TerraformResource
{
    public AwsApplicationinsightsApplication(string name) : base("aws_applicationinsights_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("auto_config_enabled");
        SetOutput("auto_create");
        SetOutput("cwe_monitor_enabled");
        SetOutput("grouping_type");
        SetOutput("id");
        SetOutput("ops_center_enabled");
        SetOutput("ops_item_sns_topic_arn");
        SetOutput("region");
        SetOutput("resource_group_name");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The auto_config_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutoConfigEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_config_enabled");
        set => SetProperty("auto_config_enabled", value);
    }

    /// <summary>
    /// The auto_create attribute.
    /// </summary>
    public TerraformProperty<bool> AutoCreate
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_create");
        set => SetProperty("auto_create", value);
    }

    /// <summary>
    /// The cwe_monitor_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CweMonitorEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("cwe_monitor_enabled");
        set => SetProperty("cwe_monitor_enabled", value);
    }

    /// <summary>
    /// The grouping_type attribute.
    /// </summary>
    public TerraformProperty<string> GroupingType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("grouping_type");
        set => SetProperty("grouping_type", value);
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
    /// The ops_center_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> OpsCenterEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ops_center_enabled");
        set => SetProperty("ops_center_enabled", value);
    }

    /// <summary>
    /// The ops_item_sns_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string> OpsItemSnsTopicArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ops_item_sns_topic_arn");
        set => SetProperty("ops_item_sns_topic_arn", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
