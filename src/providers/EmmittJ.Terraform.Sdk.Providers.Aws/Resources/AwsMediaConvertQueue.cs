using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for reservation_plan_settings in .
/// Nesting mode: list
/// </summary>
public class AwsMediaConvertQueueReservationPlanSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The commitment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Commitment is required")]
    public required TerraformProperty<string> Commitment
    {
        get => GetRequiredProperty<TerraformProperty<string>>("commitment");
        set => WithProperty("commitment", value);
    }

    /// <summary>
    /// The renewal_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RenewalType is required")]
    public required TerraformProperty<string> RenewalType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("renewal_type");
        set => WithProperty("renewal_type", value);
    }

    /// <summary>
    /// The reserved_slots attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservedSlots is required")]
    public required TerraformProperty<double> ReservedSlots
    {
        get => GetRequiredProperty<TerraformProperty<double>>("reserved_slots");
        set => WithProperty("reserved_slots", value);
    }

}

/// <summary>
/// Manages a aws_media_convert_queue resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMediaConvertQueue : TerraformResource
{
    public AwsMediaConvertQueue(string name) : base("aws_media_convert_queue", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
    }

    /// <summary>
    /// The concurrent_jobs attribute.
    /// </summary>
    public TerraformProperty<double>? ConcurrentJobs
    {
        get => GetProperty<TerraformProperty<double>>("concurrent_jobs");
        set => this.WithProperty("concurrent_jobs", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The pricing_plan attribute.
    /// </summary>
    public TerraformProperty<string>? PricingPlan
    {
        get => GetProperty<TerraformProperty<string>>("pricing_plan");
        set => this.WithProperty("pricing_plan", value);
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
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
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
    /// Block for reservation_plan_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationPlanSettings block(s) allowed")]
    public List<AwsMediaConvertQueueReservationPlanSettingsBlock>? ReservationPlanSettings
    {
        get => GetProperty<List<AwsMediaConvertQueueReservationPlanSettingsBlock>>("reservation_plan_settings");
        set => this.WithProperty("reservation_plan_settings", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
