using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_placement_group resource.
/// </summary>
public class AwsPlacementGroup : TerraformResource
{
    public AwsPlacementGroup(string name) : base("aws_placement_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("placement_group_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("partition_count");
        SetOutput("region");
        SetOutput("spread_level");
        SetOutput("strategy");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The partition_count attribute.
    /// </summary>
    public TerraformProperty<double> PartitionCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("partition_count");
        set => SetProperty("partition_count", value);
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
    /// The spread_level attribute.
    /// </summary>
    public TerraformProperty<string> SpreadLevel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spread_level");
        set => SetProperty("spread_level", value);
    }

    /// <summary>
    /// The strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Strategy is required")]
    public required TerraformProperty<string> Strategy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("strategy");
        set => SetProperty("strategy", value);
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

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    public TerraformExpression PlacementGroupId => this["placement_group_id"];

}
