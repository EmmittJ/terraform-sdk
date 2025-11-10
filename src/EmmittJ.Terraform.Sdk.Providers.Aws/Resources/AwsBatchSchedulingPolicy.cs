using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for fair_share_policy in .
/// Nesting mode: list
/// </summary>
public class AwsBatchSchedulingPolicyFairSharePolicyBlock : TerraformBlock
{
    /// <summary>
    /// The compute_reservation attribute.
    /// </summary>
    public TerraformProperty<double>? ComputeReservation
    {
        get => GetProperty<TerraformProperty<double>>("compute_reservation");
        set => WithProperty("compute_reservation", value);
    }

    /// <summary>
    /// The share_decay_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? ShareDecaySeconds
    {
        get => GetProperty<TerraformProperty<double>>("share_decay_seconds");
        set => WithProperty("share_decay_seconds", value);
    }

}

/// <summary>
/// Manages a aws_batch_scheduling_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsBatchSchedulingPolicy : TerraformResource
{
    public AwsBatchSchedulingPolicy(string name) : base("aws_batch_scheduling_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
        get => GetProperty<TerraformProperty<string>>("name");
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
    /// Block for fair_share_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FairSharePolicy block(s) allowed")]
    public List<AwsBatchSchedulingPolicyFairSharePolicyBlock>? FairSharePolicy
    {
        get => GetProperty<List<AwsBatchSchedulingPolicyFairSharePolicyBlock>>("fair_share_policy");
        set => this.WithProperty("fair_share_policy", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
