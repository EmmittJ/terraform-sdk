using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssmcontacts_rotation.
/// </summary>
public class AwsSsmcontactsRotationDataSource : TerraformDataSource
{
    public AwsSsmcontactsRotationDataSource(string name) : base("aws_ssmcontacts_rotation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("contact_ids");
        this.DeclareOutput("id");
        this.DeclareOutput("name");
        this.DeclareOutput("recurrence");
        this.DeclareOutput("start_time");
        this.DeclareOutput("tags");
        this.DeclareOutput("time_zone_id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
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
    /// The contact_ids attribute.
    /// </summary>
    public TerraformExpression ContactIds => this["contact_ids"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The recurrence attribute.
    /// </summary>
    public TerraformExpression Recurrence => this["recurrence"];

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformExpression StartTime => this["start_time"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The time_zone_id attribute.
    /// </summary>
    public TerraformExpression TimeZoneId => this["time_zone_id"];

}
