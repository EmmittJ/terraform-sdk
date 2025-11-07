using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_feature_group resource.
/// </summary>
public class AwsSagemakerFeatureGroup : TerraformResource
{
    public AwsSagemakerFeatureGroup(string name) : base("aws_sagemaker_feature_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The event_time_feature_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EventTimeFeatureName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_time_feature_name");
        set => this.WithProperty("event_time_feature_name", value);
    }

    /// <summary>
    /// The feature_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FeatureGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("feature_group_name");
        set => this.WithProperty("feature_group_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The record_identifier_feature_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecordIdentifierFeatureName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("record_identifier_feature_name");
        set => this.WithProperty("record_identifier_feature_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
