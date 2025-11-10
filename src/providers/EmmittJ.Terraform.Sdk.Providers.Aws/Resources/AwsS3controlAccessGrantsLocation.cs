using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3control_access_grants_location resource.
/// </summary>
public class AwsS3controlAccessGrantsLocation : TerraformResource
{
    public AwsS3controlAccessGrantsLocation(string name) : base("aws_s3control_access_grants_location", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("access_grants_location_arn");
        this.WithOutput("access_grants_location_id");
        this.WithOutput("id");
        this.WithOutput("tags_all");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    public required TerraformProperty<string> IamRoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("iam_role_arn");
        set => this.WithProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The location_scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationScope is required")]
    public required TerraformProperty<string> LocationScope
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location_scope");
        set => this.WithProperty("location_scope", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The access_grants_location_arn attribute.
    /// </summary>
    public TerraformExpression AccessGrantsLocationArn => this["access_grants_location_arn"];

    /// <summary>
    /// The access_grants_location_id attribute.
    /// </summary>
    public TerraformExpression AccessGrantsLocationId => this["access_grants_location_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
