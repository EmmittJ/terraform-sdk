using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3control_access_grants_instance resource.
/// </summary>
public class AwsS3controlAccessGrantsInstance : TerraformResource
{
    public AwsS3controlAccessGrantsInstance(string name) : base("aws_s3control_access_grants_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("access_grants_instance_arn");
        SetOutput("access_grants_instance_id");
        SetOutput("id");
        SetOutput("identity_center_application_arn");
        SetOutput("tags_all");
        SetOutput("account_id");
        SetOutput("identity_center_arn");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string> AccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_id");
        set => SetProperty("account_id", value);
    }

    /// <summary>
    /// The identity_center_arn attribute.
    /// </summary>
    public TerraformProperty<string> IdentityCenterArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_center_arn");
        set => SetProperty("identity_center_arn", value);
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
    /// The access_grants_instance_arn attribute.
    /// </summary>
    public TerraformExpression AccessGrantsInstanceArn => this["access_grants_instance_arn"];

    /// <summary>
    /// The access_grants_instance_id attribute.
    /// </summary>
    public TerraformExpression AccessGrantsInstanceId => this["access_grants_instance_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The identity_center_application_arn attribute.
    /// </summary>
    public TerraformExpression IdentityCenterApplicationArn => this["identity_center_application_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
