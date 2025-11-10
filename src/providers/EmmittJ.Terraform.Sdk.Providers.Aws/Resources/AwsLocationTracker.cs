using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_location_tracker resource.
/// </summary>
public class AwsLocationTracker : TerraformResource
{
    public AwsLocationTracker(string name) : base("aws_location_tracker", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("tracker_arn");
        SetOutput("update_time");
        SetOutput("description");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("position_filtering");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("tracker_name");
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
    /// The position_filtering attribute.
    /// </summary>
    public TerraformProperty<string> PositionFiltering
    {
        get => GetRequiredOutput<TerraformProperty<string>>("position_filtering");
        set => SetProperty("position_filtering", value);
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
    /// The tracker_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrackerName is required")]
    public required TerraformProperty<string> TrackerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tracker_name");
        set => SetProperty("tracker_name", value);
    }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The tracker_arn attribute.
    /// </summary>
    public TerraformExpression TrackerArn => this["tracker_arn"];

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
