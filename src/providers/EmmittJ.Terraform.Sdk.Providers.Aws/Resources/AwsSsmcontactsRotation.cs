using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for recurrence in .
/// Nesting mode: list
/// </summary>
public class AwsSsmcontactsRotationRecurrenceBlock : TerraformBlock
{
    /// <summary>
    /// The number_of_on_calls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfOnCalls is required")]
    public required TerraformProperty<double> NumberOfOnCalls
    {
        get => GetRequiredProperty<TerraformProperty<double>>("number_of_on_calls");
        set => WithProperty("number_of_on_calls", value);
    }

    /// <summary>
    /// The recurrence_multiplier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrenceMultiplier is required")]
    public required TerraformProperty<double> RecurrenceMultiplier
    {
        get => GetRequiredProperty<TerraformProperty<double>>("recurrence_multiplier");
        set => WithProperty("recurrence_multiplier", value);
    }

}

/// <summary>
/// Manages a aws_ssmcontacts_rotation resource.
/// </summary>
public class AwsSsmcontactsRotation : TerraformResource
{
    public AwsSsmcontactsRotation(string name) : base("aws_ssmcontacts_rotation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The contact_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactIds is required")]
    public List<TerraformProperty<string>>? ContactIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("contact_ids");
        set => this.WithProperty("contact_ids", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The start_time attribute.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        get => GetProperty<TerraformProperty<string>>("start_time");
        set => this.WithProperty("start_time", value);
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
    /// The time_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZoneId is required")]
    public required TerraformProperty<string> TimeZoneId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("time_zone_id");
        set => this.WithProperty("time_zone_id", value);
    }

    /// <summary>
    /// Block for recurrence.
    /// Nesting mode: list
    /// </summary>
    public List<AwsSsmcontactsRotationRecurrenceBlock>? Recurrence
    {
        get => GetProperty<List<AwsSsmcontactsRotationRecurrenceBlock>>("recurrence");
        set => this.WithProperty("recurrence", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
