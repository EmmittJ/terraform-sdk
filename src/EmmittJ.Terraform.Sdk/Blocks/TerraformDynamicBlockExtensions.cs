namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Extension methods for working with dynamic blocks on TerraformBlock instances.
/// </summary>
public static class TerraformDynamicBlockExtensions
{
    /// <summary>
    /// Converts a TerraformBlock instance into a dynamic block for fluent, type-safe dynamic block creation.
    /// </summary>
    /// <typeparam name="TBlock">The type of block being generated</typeparam>
    /// <param name="block">The block instance to convert to a dynamic block</param>
    /// <param name="forEach">The collection to iterate over</param>
    /// <param name="iterator">Optional iterator variable name (defaults to block type if null)</param>
    /// <returns>A TerraformDynamicBlock that will generate blocks of type TBlock</returns>
    /// <example>
    /// var patchScheduleBlock = new AzurermRedisCachePatchScheduleBlock("patch_schedule")
    /// {
    ///     DayOfWeek = TerraformExpression.Identifier("schedule.value.day"),
    ///     StartHourUtc = TerraformExpression.Identifier("schedule.value.hour")
    /// };
    /// var dynamicBlock = patchScheduleBlock.AsDynamic(var.patchSchedules, iterator: "schedule");
    /// </example>
    public static TerraformDynamicBlock<TBlock> AsDynamic<TBlock>(
        this TBlock block,
        ITerraformValue forEach,
        string? iterator = null)
        where TBlock : TerraformBlock
    {
        return new TerraformDynamicBlock<TBlock>(block, forEach)
        {
            Iterator = iterator
        };
    }

    /// <summary>
    /// Sets a dynamic block for a property on the parent block (type-safe version).
    /// The dynamic block replaces the existing property value.
    /// Type-safe: ensures the dynamic block's content type matches the property type at compile time.
    /// </summary>
    /// <typeparam name="TContent">The type of block being generated</typeparam>
    /// <param name="parentBlock">The parent block to add the dynamic block to</param>
    /// <param name="propertyReference">The property being replaced (used only for type checking, value is ignored)</param>
    /// <param name="dynamicBlock">The dynamic block to set</param>
    /// <example>
    /// var redisCache = new AzurermRedisCache("main");
    /// var dynamicPatchSchedule = patchScheduleBlock.AsDynamic(var.schedules);
    /// redisCache.SetDynamicBlock(redisCache.PatchSchedule, dynamicPatchSchedule);
    /// </example>
    public static void SetDynamicBlock<TContent>(
        this TerraformBlock parentBlock,
        TContent propertyReference, // Just for type inference, not actually used
        TerraformDynamicBlock<TContent> dynamicBlock)
        where TContent : TerraformBlock
    {
        if (parentBlock == null)
            throw new ArgumentNullException(nameof(parentBlock));
        if (dynamicBlock == null)
            throw new ArgumentNullException(nameof(dynamicBlock));

        // Store using the block type name from the dynamic block
        // The property storage system already handles TerraformBlock instances
        parentBlock.SetPropertyValue(dynamicBlock.BlockTypeToGenerate, dynamicBlock);
    }

    /// <summary>
    /// Sets a dynamic block for a property on the parent block (simplified version).
    /// The dynamic block replaces the existing property value.
    /// Block type is extracted from the dynamic block's content.
    /// </summary>
    /// <typeparam name="TContent">The type of block being generated</typeparam>
    /// <param name="parentBlock">The parent block to add the dynamic block to</param>
    /// <param name="dynamicBlock">The dynamic block to set</param>
    /// <example>
    /// var redisCache = new AzurermRedisCache("main");
    /// var dynamicPatchSchedule = patchScheduleBlock.AsDynamic(var.schedules);
    /// redisCache.SetDynamicBlock(dynamicPatchSchedule);
    /// </example>
    public static void SetDynamicBlock<TContent>(
        this TerraformBlock parentBlock,
        TerraformDynamicBlock<TContent> dynamicBlock)
        where TContent : TerraformBlock
    {
        if (parentBlock == null)
            throw new ArgumentNullException(nameof(parentBlock));
        if (dynamicBlock == null)
            throw new ArgumentNullException(nameof(dynamicBlock));

        parentBlock.SetPropertyValue(dynamicBlock.BlockTypeToGenerate, dynamicBlock);
    }
}
