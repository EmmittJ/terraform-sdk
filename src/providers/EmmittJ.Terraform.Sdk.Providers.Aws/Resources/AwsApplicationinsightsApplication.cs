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
        this.WithOutput("arn");
    }

    /// <summary>
    /// The auto_config_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoConfigEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("auto_config_enabled");
        set => this.WithProperty("auto_config_enabled", value);
    }

    /// <summary>
    /// The auto_create attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoCreate
    {
        get => GetProperty<TerraformProperty<bool>>("auto_create");
        set => this.WithProperty("auto_create", value);
    }

    /// <summary>
    /// The cwe_monitor_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CweMonitorEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cwe_monitor_enabled");
        set => this.WithProperty("cwe_monitor_enabled", value);
    }

    /// <summary>
    /// The grouping_type attribute.
    /// </summary>
    public TerraformProperty<string>? GroupingType
    {
        get => GetProperty<TerraformProperty<string>>("grouping_type");
        set => this.WithProperty("grouping_type", value);
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
    /// The ops_center_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? OpsCenterEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ops_center_enabled");
        set => this.WithProperty("ops_center_enabled", value);
    }

    /// <summary>
    /// The ops_item_sns_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? OpsItemSnsTopicArn
    {
        get => GetProperty<TerraformProperty<string>>("ops_item_sns_topic_arn");
        set => this.WithProperty("ops_item_sns_topic_arn", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
